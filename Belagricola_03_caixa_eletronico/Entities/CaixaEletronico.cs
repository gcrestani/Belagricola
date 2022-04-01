using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belagricola_03_caixa_eletronico.Entities
{
    class CaixaEletronico
    {
        static readonly int[] Banknotes = { 100, 50, 20, 10, 5, 2 };

        static public string Withdraw(int value)
        {
            int[] qtyBanknotes = { 0, 0, 0, 0, 0, 0 }; //representing notes of 100, 50, 20, 10, 5, 2
            for (int i = 0; i < Banknotes.Length; i++)
            {
                if (value>=Banknotes[i])
                {
                    qtyBanknotes[i] = (value / Banknotes[i]);
                    value = value % Banknotes[i];
                }
            }
            
            if (value > 0)
            {
                return "Erro: o valor a ser sacado deve ser divisível por 2 ou por 5.";
            }

            string notes = "";
            for (int i = 0; i < qtyBanknotes.Length; i++)
            {
                if (qtyBanknotes[i]>0)
                {
                    notes += qtyBanknotes[i].ToString("F0") + " nota(s) de R$" + Banknotes[i].ToString("F2") + "\n";
                }
            }

            if (notes !="")
            {
                return "\nSaque realizado com sucesso.\n" + notes;
            }
            else
            {
                return "Erro. Valor mínimo para saque: R$" + Banknotes.Min().ToString("F2");
            }
        }
    }
}
