
// === LAMBDA ===
// Esempio di utilizzo di Func ed Action.
// ==============


// Funzione o metodo
void StampaHelloWorld() {
    Console.WriteLine("Hello, World!");
}

StampaHelloWorld();


// Action da funzione o metodo
Action action = StampaHelloWorld;

action();


// Action da lambda
Action daLambda = () => Console.WriteLine("Lambda!");

daLambda();


// Parametri
Action<int> conParam = (int parametro) => Console.WriteLine($"Parametro: {parametro}");

conParam(1);
conParam(2);
conParam(3);


// Func
Func<int, int> raddoppia = (int valore) => valore * 2;

Console.WriteLine($"A: {raddoppia(10)}");
Console.WriteLine($"B: {raddoppia(20)}");
Console.WriteLine($"C: {raddoppia(30)}");


// Calcolatrice
Dictionary<string, Func<double, double, double>> operazioni = new() {
    ["+"] = (double a, double b) => a + b,
    ["-"] = (double a, double b) => a - b,
    ["*"] = (double a, double b) => a * b,
    ["/"] = (double a, double b) => a / b,
};

void StampaEspressione(double a, string operatore, double b) {
    Func<double, double, double> func = operazioni[operatore];
    Console.WriteLine($"{a} {operatore} {b} = {func(a, b)}");
}

StampaEspressione(1, "+", 2);
StampaEspressione(5, "-", 3);
StampaEspressione(10, "*", 5);
StampaEspressione(20, "/", 4);
