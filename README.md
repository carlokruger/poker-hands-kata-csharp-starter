# Poker Hands Kata - C# Starter

Welcome to the Poker Hands kata! This project is all set up so you can jump straight into coding.

## The Challenge

Your mission, should you choose to accept it, is to compare poker hands and determine the winner.

A poker hand consists of 5 cards dealt from the deck. Poker hands are ranked by the following hierarchy:

1. **High Card**: Highest value card
2. **Pair**: Two cards of the same value
3. **Two Pairs**: Two different pairs
4. **Three of a Kind**: Three cards of the same value
5. **Straight**: All cards are consecutive values
6. **Flush**: All cards of the same suit
7. **Full House**: Three of a kind and a pair
8. **Four of a Kind**: Four cards of the same value
9. **Straight Flush**: All cards consecutive values of same suit
10. **Royal Flush**: Ten, Jack, Queen, King, Ace of same suit

### Card Values
- Numeric cards (2-10) have face value
- Jack = 11, Queen = 12, King = 13, Ace = 14

### Input Format
Hands are represented as strings with 5 cards separated by spaces:
- Example: `"2H 3D 5S 9C KD"`
- First character is the value (2-9, T, J, Q, K, A)
- Second character is the suit (H = Hearts, D = Diamonds, S = Spades, C = Clubs)

### Your Task
Implement the `Compare` method in `PokerHandComparer.cs` to return:
- `"Player 1 wins"` if player 1's hand is better
- `"Player 2 wins"` if player 2's hand is better
- `"Tie"` if both hands are equal

## Project Structure

```
PokerHands.Lib/          - Your implementation code goes here
  Card.cs                - Represents a single card
  Hand.cs                - Represents a 5-card hand
  PokerHandComparer.cs   - Main comparison logic (implement this!)

PokerHands.Tests/        - Your tests go here
  PokerHandComparerTests.cs - Some starter tests
```

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later

### Build and Run Tests

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run the tests
dotnet test

# Run tests with detailed output
dotnet test --logger "console;verbosity=detailed"
```

### Development Workflow

1. Run the tests - they should fail (that's expected!)
2. Implement the comparison logic incrementally
3. Start simple (high card comparison) and build up to more complex hands
4. Add more tests as you go
5. Refactor when needed

## Tips

- Start with the simplest cases first (high card vs high card)
- Build up to more complex hands gradually
- Don't try to do everything at once
- Test-driven development works great for this kata
- Feel free to add more classes if it helps organize your code

## Example Test Cases

```csharp
// High card vs High card
"2H 3D 5S 9C KD" vs "2C 3H 4S 8C AH" → Player 2 wins (Ace high)

// Pair vs High card
"2H 2D 5S 9C KD" vs "3C 4H 5S 8C AH" → Player 1 wins (pair beats high card)

// Flush vs Straight
"2H 4H 6H 8H TH" vs "3D 4S 5C 6H 7D" → Player 1 wins (flush beats straight)
```

Good luck and have fun!
