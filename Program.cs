Console.WriteLine("           Ursos");
// Console.WriteLine();
Console.WriteLine("Digite S para sair, ou qualquer outra tecla para continuar!");

string sexo;
double peso;

int qtdUrsos = 0, qtdFemeas = 0, qtdMachos;

// qML = quantidade muito leve
// qL = quantidade leve 
// qM = quantidade médio
// qP = quantidade pesado
// qMP = quantidade muito pesado

// qMLm = quantidade muito leve macho...

// qMLf = quantidade muito leve fêmea...
int qML = 0, qL = 0, qM = 0, qP = 0, qMP = 0;
int qMLm = 0, qLm = 0, qMm = 0, qPm = qMPm = 0;
int qMLf = 0, qLf = 0, qMf = 0, qPf = 0, qMPf = 0;

double percentualML = 0, percentualL = 0, percentualM = 0, percentualP = 0, percentualMP = 0;
double percentualMachos = 0 percentualMLm = 0, percentualLm = 0, percentualMm = 0, percentualPm = 0, percentualMPm = 0;
double percentualFemeas = 0 percentualMLf = 0, percentualLf = 0, percentualMf = 0, percentualPf = 0, percentualMPf = 0;

string SexoMP = "";
double MaiorP = 0;

double somaPesos = 0, somaPesosMachos = 0, somaPesosFemeas = 0;
double mediaPeso = 0, mediaPesoMachos = 0, mediaPesoFemeas = 0; 

string tecla = "S";
while(tecla != "S" );
{
    Console.WriteLine($"\n    Urso #{qtdUrsos ++}");

    Console.Write("Peso (até 250kg): ");
    peso = Convert.ToDouble(Console.ReadLine());

    if (peso <= 0 || peso > 250) break;

    Console.Write("Sexo, macho ou fêmea: ");
    sexo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

    if (sexo != "macho" && sexo != "fêmea") break;

    qtdUrsos++;

    switch (sexo)
    {
        case "macho": qtdMachos++; somaPM += peso; break;
        case "fêmea": qtdFêmeas++; somaPF += peso; break;
    }


    tecla = Console.ReadLine()!;
}

if (peso <= 50 && sexo == "macho") qMLm++;
{
    else if (peso <= 100 && sexo == "macho") qLm++;
    else if (peso <= 150 && sexo == "macho") qMm++;
    else if (peso <= 200 && sexo == "macho") qPm++;
    else if (peso <= 250 && sexo == "macho") qMPm++;
    else if (peso <= 50 && sexo == "fêmea") qMLf++;
    else if (peso <= 100 && sexo == "fêmea") qLf++;
    else if (peso <= 150 && sexo == "fêmea") qMf++;
    else if (peso <= 200 && sexo == "fêmea") qPf++;
    else if (peso <= 250 && sexo == "fêmea") qMPf++;

    if (peso > MaiorP)
    {
    MaiorP = peso;
    SexoMP = sexo;
    }
}

if (qtdUrsos == 0) return;

qML = qMLm + qMLf;
qL = qLm + qLf;
qM = qMm + qMf;
qP = qPm + qPf;
qMP = qMPm + qMPf;

percentualML = (double)qML / qtdUrsos * 100;
percentualL = (double)qL / qtdUrsos * 100;
percentualM = (double)qM / qtdUrsos * 100;
percentualP = (double)qP / qtdUrsos * 100;
percentualMP = (double)qMP / qtdUrsos * 100;

percentualMachos = (double)qtdMachos / qtdUrsos * 100;
percentualFemeas = (double)qtdFemeas / qtdUrsos * 100;

somaPesos = somaPesosMachos + somaPesosFemeas;

mediaPeso =  somaPesos / qtdUrsos;

if (qtdMachos > 0)
{
    percentualMLm = (double) qMLm / qtdMachos * 100;
    percentualLm = (double) qLm / qtdMachos * 100;
    percentualMm = (double) qMm / qtdMachos * 100;
    percentualPm = (double) qPm / qtdMachos * 100;
    percentualMPm = (double) qMPm / qtdMachos * 100;

    mediaPesoMachos = somaPesosMachos / qtdMachos;

}

if (qtdFemeas > 0)
{
    percentualMLf = (double) qMLf / qtdFemeas * 100;
    percentualLf = (double) qLf / qtdFemeas  * 100;
    percentualMf = (double) qMf / qtdFemeas  * 100;
    percentualPf = (double) qPf / qtdFemeas  * 100;
    percentualMPf = (double) qMPf / qtdFemeas  * 100;

    mediaPesoFemeas = somaPesosFemeas / qtdFemeas ;
    
}














