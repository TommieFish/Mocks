// Determines whether a household eats out today AND checks that there is an outlet
// within 200 units of the household's location. This now uses x and y meaningfully.
//line 114
public bool FindOutIfHouseholdEatsOut(int householdNo, ref int x, ref int y)
{
    // Get the household's coordinates
    x = households[householdNo].GetX();
    y = households[householdNo].GetY();

    // First check: does the household WANT to eat out today?
    double eatOutRNo = rnd.NextDouble();
    if (eatOutRNo >= households[householdNo].GetChanceEatOut())
    {
        return false;
    }

    // Second check: is there an outlet within 200 units?
    // (This gives x and y a real purpose.)
    foreach (var company in Program.simulation.companies)
    {
        foreach (var outlet in company.GetListOfOutlets())
        {
            double dx = outlet.GetX() - x;
            double dy = outlet.GetY() - y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance <= 200)
            {
                return true; // Household eats out AND has a nearby outlet
            }
        }
    }

    return false; // No outlet close enough
}



//----------------------------------------------------------------------------------------------
//When adding a new outlet, check that an outlet is not already at those co-ordinates

// Checks whether any existing outlet already uses the given coordinates
private bool CoordinatesInUse(int x, int y)
{
    foreach (var c in companies)
    {
        foreach (int outletIndex in c.GetListOfOutlets())
        {
            Outlet o = c.outlets[outletIndex];
            if (o.GetX() == x && o.GetY() == y)
            {
                return true; // Found an outlet at these coordinates
            }
        }
    }
    return false; // No outlet uses these coordinates
}

//Line 794 - 801
// Check coordinates are inside the settlement
if (x >= 0 && x < simulationSettlement.GetXSize() &&
    y >= 0 && y < simulationSettlement.GetYSize())
{
    // NEW: check if coordinates are already used
    if (CoordinatesInUse(x, y))
    {
        Console.WriteLine("Those coordinates are already used by an existing outlet.");
    }
    else
    {
        companies[index].OpenOutlet(x, y);
        Console.WriteLine("Outlet successfully opened.");
    }
}
else
{
    Console.WriteLine("Invalid coordinates.");
}
