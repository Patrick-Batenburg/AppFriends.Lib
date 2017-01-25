# AppFriends.Lib
NuGet Package

```c#
/// <summary>
/// Returns objects values interacting with current player and hit a player for a set amount or for a random amount of lifes.
/// </summary>
/// <param name="target">Taget player to hit.</param>
/// <param name="amount">Amount lifes to substract, if left null a random amount is used.</param>
/// <param name="print">Whenever to print message to console, default is false.</param>
/// <returns>Returns objects values interacting with current player.</returns>
public string[] Hit(Player target, int? amount = null, bool print = false)
```

```c#
/// <summary>
/// Returns objects values interacting with current player and give a set amount or a random amount of lifes to a player.
/// </summary>
/// <param name="target">Taget player to give lifes to.</param>
/// <param name="amount">Amount lifes to add, if left null a random amount is used.</param>
/// <param name="print">Whenever to print message to console, default is false.</param>
/// <returns>Returns objects values interacting with current player.</returns>
public string[] GiveLife(Player target, int? amount = null, bool print = false)
```

```c#
/// <summary>
/// Returns objects values interacting with current player and gives a set amount or a random amount of money.
/// </summary>
/// <param name="amount">Amount of money to add, if left null a random amount is used.</param>
/// <param name="print">Whenever to print message to console, default is false.</param>
/// <returns>Returns objects values interacting with current player.</returns>
public string[] GetMoney(int? amount = null, bool print = false)
```

```c#
/// <summary>
/// Name of current player to get or set.
/// </summary>
public string Name
```

```c#
/// <summary>
/// Life of current player to get or set.
/// </summary>
public int Life
```

```c#
/// <summary>
/// Money of current player to get or set.
/// </summary>
public int Money
```
