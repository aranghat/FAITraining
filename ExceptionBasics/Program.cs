using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your fav number :");
                int favNumber = int.Parse(Console.ReadLine());

                ValidateFavNumber validate 
                    = new ValidateFavNumber();
                validate.Validate(favNumber);
            }
            #region

            catch(FormatException forMatException)
            {
                Console.WriteLine(forMatException.StackTrace);
                Console.WriteLine(forMatException.Message);
                Console.WriteLine(forMatException.HelpLink);
                Console.WriteLine(forMatException.InnerException);
                Console.WriteLine("Looks like you have given a wrong value");
            }
            catch(OverflowException overFlowException)
            {
                Console.WriteLine("Think about a smaller fav number");
            }
            #endregion
            catch(InvalidFavNumberException excp)
            {
                Console.WriteLine(excp.Message);
                Console.WriteLine($"For more info visit {excp.HelpLink}");
            }
            catch (Exception excp)
            {
                //Console.WriteLine(excp.Message);
                //Console.WriteLine(excp.StackTrace);
                // throw excp;
                throw;
            }
            catch
            {

            }
            finally
            {
                Console
                    .WriteLine("Finally will always be execute");
            }
        }
    }
}
