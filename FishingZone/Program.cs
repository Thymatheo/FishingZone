// See https://aka.ms/new-console-template for more information
using FishingZone;
if (args.Length > 0)
	if (int.TryParse(args[0], out int weekNumber))
		Console.WriteLine(WorldEvent.GetFishingZoneBonus(weekNumber));
	else
		Console.WriteLine($"Unable to parse : {args[0]} to a week number please try again");
else Console.WriteLine("Please give a week number in argument of the software!");
