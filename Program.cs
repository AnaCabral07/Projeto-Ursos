Console.WriteLine("           Ursos");
// Console.WriteLine();
Console.WriteLine("Digite S para sair, ou qualquer outra tecla para continuar!");

string sexo;
double peso;

int qtdUrsos = 0, qtdFêmeas = 0, qtdMachos;

// qML = quantidade muito leve
// qL = quantidade leve 
// qM = quantidade médio
// qP = quantidade pesado
// qMP = quantidade muito pesado

// qMLM = quantidade muito leve macho...

// qMLF = quantidade muito leve fêmea...
int qML = 0, qL = 0, qM = 0, qP = 0, qMP = 0;
int qMLh = 0, qLh = 0, qMh = 0, qPh = qMPh = 0;
int qMLf = 0, qLf = 0, qMf = 0, qPf = 0, qMPf = 0;

double percentualML = 0, percentualL = 0, percentualM = 0, percentualP = 0, percentualMP = 0;
double percentualMLh = 0, percentualLh = 0, percentualMh = 0, percentualPh = 0, percentualMPh = 0;
double percentualMLf = 0, percentualLf = 0, percentualMf = 0, percentualPf = 0, percentualMPf = 0;

string SexoMP;
double MaiorP;

string tecla = "";
while(tecla != "S" );
{
    Console.WriteLine($"\n    Urso #{qtdUrsos ++}");

    Console.Write("Peso (até 250kg): ");
    peso = Convert.ToDouble(Console.ReadLine());

    if (peso <= 0 || peso > 250) break;

    Console.Write("Sexo, machio ou fêmeio: ");
    sexo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

    if (sexo != "machio" && sexo != "fêmio") break;

    qtdUrsos++;

    switch (sexo)
    {
        case "machio": qtdMachos++; somaPM += peso; break;
        case "fêmio": qtdFêmeas++; somaPF += peso; break;
    }


    tecla = Console.ReadLine()!;
}
