using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace src
{
    class Aluno
    {
        public String Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override String ToString()
        {
            double notaFinal = NotaFinal();

            if(notaFinal < 60.0)
            {
                return "Nota Final = " 
                    + notaFinal.ToString("F2", CultureInfo.InvariantCulture) 
                    + Environment.NewLine 
                    + "Aluno reprovado."
                    + Environment.NewLine
                    + "Faltaram "
                    + (60.0-notaFinal).ToString("F2", CultureInfo.InvariantCulture)
                    + " pontos.";
            }
            else
            {
                return "Nota Final = " 
                    + notaFinal.ToString("F2", CultureInfo.InvariantCulture) 
                    + Environment.NewLine 
                    + "Aluno aprovado.";
            }
        }
    }
}
