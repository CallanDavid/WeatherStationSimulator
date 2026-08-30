# Weather Station Simulator

<sub>Documentation drafted with claude.ai</sub>

A console app that generates a run of random daily weather and reports on it.
Enter a number of days and it produces a temperature and condition for each, then
summarises.

Reports the average, maximum and minimum temperature, plus the most common
condition across the run.

## Running it

    dotnet run

Targets .NET 9.

Written as an arrays exercise - the average and most-common-condition calculations
are done with explicit loops rather than LINQ, which was the point.
