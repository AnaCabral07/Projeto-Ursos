Console.WriteLine("           Ursos sem Curso");
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
double percentualMachos = 0, percentualMLm = 0, percentualLm = 0, percentualMm = 0, percentualPm = 0, percentualMPm = 0;
double percentualFemeas = 0, percentualMLf = 0, percentualLf = 0, percentualMf = 0, percentualPf = 0, percentualMPf = 0;

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
{   else 
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

Console.WriteLine($"\nUrso mais pesado: {MaiorP} ({SexoMP})");
Console.WriteLine($"Pesos médios: \n\tMachos = {mediaPesoMachos:N1}\n\tFêmeas = {mediaPesoFemeas:N1}\n\tGeral  = {mediaPeso:N1}\n");

Console.WriteLine("Categoria       Ursos    Ursos (%)    Machos   Machos (%)    Fêmeas  Fêmeas (%)");
Console.WriteLine("".PadLeft(79, '-'));
Console.WriteLine($"{"ML",-10} {qML,10} {percentualML,10:N1}% {qMLm,10} {percentualMLm,10:N1}% {qMLf,10} {percentualMLf,10:N1}%");
Console.WriteLine($"{"L",-10} {qL,10} {percentualL,10:N1}% {qLm,10} {percentualLm,10:N1}% {qLf,10} {percentualLf,10:N1}%");
Console.WriteLine($"{"M",-10} {qM,10} {percentualM,10:N1}% {qMm,10} {percentualMm,10:N1}% {qMf,10} {percentualMf,10:N1}%");
Console.WriteLine($"{"P",-10} {qP,10} {percentualP,10:N1}% {qPm,10} {percentualPm,10:N1}% {qPf,10} {percentualPf,10:N1}%");
Console.WriteLine($"{"MP",-10} {qMP,10} {percentualMP,10:N1}% {qMPm,10} {percentualMPm,10:N1}% {qMPf,10} {percentualMPf,10:N1}%");
Console.WriteLine("".PadLeft(79, '-'));
Console.WriteLine($"{"Total",-10} {qtdUrsos,10} {100,10}% {qtdMachos,10} {percentualMachos,10:N1}% {qtdFemeas,10} {percentualFemeas,10:N1}%");

Console.WriteLine("\n----- Ursos Machos -----");
Console.WriteLine("   +...10...20...30...40...50...60...70...80...90..100");
Console.WriteLine($"ML |{"".PadRight((int)percentualMLm / 2, '*')}");
Console.WriteLine($"L  |{"".PadRight((int)percentualLm / 2, '*')}");
Console.WriteLine($"M  |{"".PadRight((int)percentualMm / 2, '*')}");
Console.WriteLine($"P  |{"".PadRight((int)percentualPm / 2, '*')}");
Console.WriteLine($"MP |{"".PadRight((int)percentualMPm / 2, '*')}");

Console.WriteLine("\n----- Ursos Femeas -----");
Console.WriteLine("   +...10...20...30...40...50...60...70...80...90..100");
Console.WriteLine($"ML |{"".PadRight((int)percentualMLf / 2, '*')}");
Console.WriteLine($"L  |{"".PadRight((int)percentualLf / 2, '*')}");
Console.WriteLine($"M  |{"".PadRight((int)percentualMf / 2, '*')}");
Console.WriteLine($"P  |{"".PadRight((int)percentualPf / 2, '*')}");
Console.WriteLine($"MP |{"".PadRight((int)percentualMPf / 2, '*')}");

Console.WriteLine("\n----- Ursos (todos) -----");
Console.WriteLine("   +...10...20...30...40...50...60...70...80...90..100");
Console.WriteLine($"ML |{"".PadRight((int)percentualML / 2, '*')}");
Console.WriteLine($"L  |{"".PadRight((int)percentualL / 2, '*')}");
Console.WriteLine($"M  |{"".PadRight((int)percentualM / 2, '*')}");
Console.WriteLine($"P  |{"".PadRight((int)percentualP / 2, '*')}");
Console.WriteLine($"MP |{"".PadRight((int)percentualMP / 2, '*')}");














