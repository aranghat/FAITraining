
ALTER PROC [dbo].[spCreateOrder]
@ProductId INT,
@TotalQuantity INT,
@CustomerId INT,
@OrderId INT OUTPUT
AS
BEGIN
	 --GET THE UNIT PRICE AND CALCULATE THE FINAL AMOUNT
	DECLARE @UnitPrice FLOAT
	SET @UnitPrice = (SELECT UnitPrice FROM Products WHERE ID = @ProductId)

	DECLARE @CurrentStock INT = (SELECT TotalStock FROM Products WHERE ID = @ProductId)

	IF(@CurrentStock >= @TotalQuantity)
		BEGIN

		DECLARE @TotalAmount FLOAT = (@UnitPrice * @TotalQuantity)

		IF(@TotalAmount IS NOT NULL)
			BEGIN -- {

				BEGIN TRAN T1

				BEGIN TRY
				
						INSERT INTO Orders(CustomerId,ProductId,Qty,Amount,DeliveryStatus)
								Values(@CustomerId,@ProductId,@TotalQuantity,@TotalAmount,'PENDING');

						 SET @OrderId  = SCOPE_IDENTITY();

						IF(@OrderId > 0)
							BEGIN
								UPDATE Products
								SET TotalStock = @CurrentStock - @TotalQuantity
								WHERE ID = @ProductId
							END
						COMMIT TRAN T1
				END TRY
				BEGIN CATCH 
						ROLLBACK TRAN T1;
						THROW 10001, 'COULD NOT CREATE ORDER AT THIS TIME',  1;
				END CATCH

			END -- }
		ELSE
			BEGIN
				PRINT 'INVALID ID';
				THROW 10002, 'INVALID PRODUCT ID',  1;
			END

	END

	RETURN @OrderId
END
GO


