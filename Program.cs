// Factory Pattern - Skapar hotellrum dynamiskt
public abstract class Hotellrum
{
    public abstract void VisaRum();
}

public class Enkelrum : Hotellrum
{
    public override void VisaRum() => Console.WriteLine("Detta är ett enkelrum.");
}

public class Dubbelrum : Hotellrum
{
    public override void VisaRum() => Console.WriteLine("Detta är ett dubbelrum.");
}

public class Svit : Hotellrum
{
    public override void VisaRum() => Console.WriteLine("Detta är en svit.");
}

public class RumFabrik
{
    public static Hotellrum SkapaRum(string typ)
    {
        return typ switch
        {
            "Enkelrum" => new Enkelrum(),
            "Dubbelrum" => new Dubbelrum(),
            "Svit" => new Svit(),
            _ => throw new ArgumentException("Ogiltig rumstyp")
        };
    }
}

