using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	using System;

	namespace FactoryDesignPattern
	{
		public interface IDocument
		{
			string GetNumber();
			void GetDocument();
		}
		class Factura : IDocument
		{
			private string serie;
			public Factura(string Number)
			{
				serie = Number;
			}


			public string GetNumber()
			{
				return serie;
			}
			public void GetDocument()
			{
				Console.WriteLine("Document is a Invoice");
			}
		}
		class NotadeCredito : IDocument
		{
			private string serie;
			public NotadeCredito(string Number)
			{
				serie = Number;
			}
			public string GetNumber()
			{
				return  serie;
			}
			public void GetDocument()
			{
				Console.WriteLine("This is a Credit Note");
			}

			
		}

		

		static class DocumentFactory
		{
			public static IDocument GetDocinstance(int Id,string numserie)
			{   
				 string serial=numserie;
				switch (Id)
				{    case 0:
						return new Factura(serial);
					case 1:
						return new NotadeCredito(serial);
					default:
						return null;
				}

		
	}
		}
		class ClientProgram
		{
			static void Main(string[] args)
			{

				IDocument objDocSupplier = DocumentFactory.GetDocinstance(0,"00001");
				objDocSupplier.GetDocument();
				Console.WriteLine("And Number is "+objDocSupplier.GetNumber());

				IDocument objDocSupplier1 = DocumentFactory.GetDocinstance(1, "00028");
				objDocSupplier1.GetDocument();
				Console.WriteLine("And Number is " + objDocSupplier1.GetNumber());
				Console.ReadLine();
			}

		}
	}
}
