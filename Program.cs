{
        // Sistema de banco SAQUE & DEPOSITO!

        double saldo = 1000;

        Console.WriteLine("___________________________");
        Console.WriteLine("");
        Console.WriteLine("SEJA BEM VINDO AO SEU BANCO");
        Console.WriteLine("___________________________");
        Console.WriteLine("");

        Console.WriteLine("Seu saldo é:"+saldo);
        Console.WriteLine("");

        Console.WriteLine("Digite 1 para saque.");
        Console.WriteLine("Digite 2 para deposito.");
        Console.Write("Informe aqui:");
        int N1 = int.Parse(Console.ReadLine());

        Console.Clear();

        int opção = N1;

        if(opção == 1)
        {
            Console.Write("Informe o valor de saque:");
            double saque = double.Parse(Console.ReadLine());
            double saq = saldo - saque;

            if(saldo >= saque)
            {
            Console.WriteLine("Operação bem sucedida!");
            Console.WriteLine("Seu saldo atual é:"+saq);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }
        else
        {
            if(opção == 2)
            {
            Console.Write("Informe o valor de deposito:");
            double deposito = double.Parse(Console.ReadLine());
            double dep = deposito + saldo;
            Console.WriteLine("Operação bem sucedida!");
            Console.WriteLine("Seu saldo atual é:"+dep);
            }
        }
        if(opção >=3)
        {
            Console.WriteLine("Operação não existe.");
            Console.WriteLine("Tente novamente");
            Console.Write("Informe novamente:");
            int N2 = int.Parse(Console.ReadLine());

            int retorno = N2;
            
            if(retorno == 1)
        {
            Console.Write("Informe o valor de saque:");
            double saque = double.Parse(Console.ReadLine());
            double saq = saldo - saque;

            if(saldo >= saque)
            {
            Console.WriteLine("Operação bem sucedida!");
            Console.WriteLine("Seu saldo atual é:"+saq);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }
        else
        {
            if(retorno == 2)
            {
            Console.Write("Informe o valor de deposito:");
            double deposito = double.Parse(Console.ReadLine());
            double dep = deposito + saldo;
            Console.WriteLine("Operação bem sucedida!");
            Console.WriteLine("Seu saldo atual é:"+dep);
            }            
        }
    
    }
}