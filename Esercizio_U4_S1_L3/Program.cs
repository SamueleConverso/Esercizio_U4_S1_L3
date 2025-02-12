using Esercizio_U4_S1_L3.Models;


//ESERCIZIO 1

Console.WriteLine("Ciao! Vuoi aprire un conto corrente? (s/n)");
var apriConto = Console.ReadLine()?.ToLower();
var nomeUtenteConto = "";
var saldoIniziale = 0;
ContoCorrente nuovoConto;

if (apriConto == "s") {
    Console.WriteLine("Come ti chiami? Questo sarà anche il nome del tuo conto.");
    nomeUtenteConto = Console.ReadLine();
    Console.WriteLine("Qual è il tuo saldo iniziale?");
    saldoIniziale = int.Parse(Console.ReadLine()!);
    nuovoConto = new ContoCorrente(nomeUtenteConto!, saldoIniziale);

    if (nuovoConto.SaldoConto == 0) {
        Environment.Exit(0);
    }

    //

    bool repeatActions = true;
    //repeat:
    while (repeatActions) {
        Console.WriteLine("Cosa vuoi fare ora? (versa/preleva/*)");
        var azione = Console.ReadLine()?.ToLower();
        if (azione == "versa") {
            Console.WriteLine("Quanto vuoi versare?");
            var versamento = int.Parse(Console.ReadLine()!);
            nuovoConto.Versa(versamento);
            Console.WriteLine($"Il tuo saldo ora ammonta a: {nuovoConto.SaldoConto}");
            //goto repeat;
        } else if (azione == "preleva") {
            Console.WriteLine("Quanto vuoi prelevare?");
            var prelevamento = int.Parse(Console.ReadLine()!);
            nuovoConto.Preleva(prelevamento);
            Console.WriteLine($"Il tuo saldo ora ammonta a: {nuovoConto.SaldoConto}");
            //goto repeat;
        } else {
            Console.WriteLine("Arrivederci!");
            repeatActions = false;
            //return;
        }
    }
} else {
    Console.WriteLine("Arrivederci!");
    return;
}






// ESERCIZIO 2

//string[] nomi = new string[] { "Samuele", "Flavio", "Gianfranco" };

//void verificaNome(string[] arr, string str) {
//    bool trovato = false;
//    for (int i = 0; i < nomi.Length; i++) {
//        if (arr[i] == str) {
//            trovato = true;
//            break;
//        } else {
//            trovato = false;
//        }
//    }
//    if (trovato) {
//        Console.WriteLine("Il nome è stato trovato!");
//    }
//}

//verificaNome(nomi, "Flavio");






// ESERCIZIO 3

//Console.WriteLine("Inserisci dimensione array:");
//var dimensione = int.Parse(Console.ReadLine()!);

//int[] nums = new int[dimensione];

//for (int i = 0; i < dimensione; i++) {
//    Random num = new Random();
//    nums[i] = num.Next(1, 100);
//}

//void StampaSommaEMedia(int[] arr) {
//    int somma = 0;
//    int media = 0;

//    for (int i = 0; i < dimensione; i++) {
//        somma += arr[i];
//    }

//    media = somma / dimensione;

//    Console.WriteLine("La somma degli elementi dell'array è: " + somma);
//    Console.WriteLine("La media degli elementi dell'array è: " + media);
//}

//StampaSommaEMedia(nums);
