namespace Models;

public class Courant
{
	private double _ligneDeCredit;

    public string Numero { get; set; }
    public Personne Titulaire { get; set; }
    public double Solde { get; private set; }
	public double LigneDeCredit
	{
		get { return _ligneDeCredit; }
		set {
			if(value >= 0)
			{
				_ligneDeCredit = value;
			}
			/* Pour une application Console, c'est OK, mais pas pour les autres...
				Donc on évite ce genre de code, et utilisons la gestion d'exceptions et d'événements
			else
			{
                Console.WriteLine("Ligne de crédit en négatif...");
            }*/
		}
	}

	public void Depot(double montant)
	{
		if (montant <= 0) return;		//Gestion des exceptions
		Solde += montant;
	}

	public void Retrait(double montant)
	{
		if (montant <= 0) return;							//Gestion des exceptions
		if (montant > Solde + LigneDeCredit) return;		//Gestion des exceptions
		Solde -= montant;
    }

	public static double operator + (Courant left, Courant right)
	{
		double result = 0;
		if (left.Solde > 0) result += left.Solde;
		if (right.Solde > 0) result += right.Solde;
		return result;
	}

	public static double operator + (double left, Courant right)
	{
		double result = left;
		if (right.Solde > 0) result += right.Solde;
		return result;
	}
}
