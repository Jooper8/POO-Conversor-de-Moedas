using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Conversor_de_Moedas
{
    //Declaração da classe CDM (Conversor De Moeda.)
    class CDM
    {
        //Declaração das variáveis double ValorReal e ValorTotal. A primeira será utilizada para converter o valor do dólar para o real, e o segundo representa o valor total.
        double ValorReal, ValorTotal;
        //Declaração da variável CotaDolar, utilizando automatic properties. Representa o valor que multiplicará ValorDolar.
        double CotaDolar { get; set; }
        //Declaração da variável ValorDolar, utilizando automatic properties. Representa o valor que será convertido em ValorReal.
        double ValorDolar { get; set; }
        //Declaração da variável double que carrega o valor atual do IOF, no momento da escrita do script.
        //Valor encontrado em https://www.istoedinheiro.com.br/mudancas-no-iof-passam-a-valer-hoje-veja-como-isso-atinge-o-seu-bolso/.
        double IOF = .0411;
        //Declaração do construtor desta classe, que será utilizado no programa principal.
        public CDM(double cotaDolar, double valorDolar)
        {
            //Associação do CotaDolar com o valor cotaDolar que será preenchido no programa principal.
            CotaDolar = cotaDolar;
            //Associação do ValorDolar com o valor valorDolar que será preenchido no programa principal.
            ValorDolar = valorDolar;
        }
        //Método da classe que será utilizado pelo programa principal.
        public void CalculoRealETotal()
        {
            //Cálculo do valor em real, inserido pelo usuário como valor em dólares e cotação.
            ValorReal = CotaDolar * ValorDolar;
            //Cálculo do valor total, que leva em conta o valor fixo (no script) do IOF e o valor em real calculado anteriormente.
            ValorTotal = ValorReal + (ValorReal * IOF);
        }
        //Método de sobrecarga que retorna os dados calculados na classe.
        public override string ToString()
        {
            //Exibição da mensagem sobre o valor a ser pago em real.
            return "Valor a ser pago em reais = "
                + ValorReal.ToString("C2") //Exibição do valor em real da conversão.
                + "\nValor a ser pago de IOF = " //Exibição da mensagem sobre o valor do IOF do script.
                + IOF.ToString("P3") //Exibição do valor IOF fixado no script.
                + "\nValor total da compra com IOF = " //Exibição da mensagem sobre o valor total a ser pago.
                + ValorTotal.ToString("C2"); //Exibição do valor em reais junto ao IOF.
        }
    }
}
