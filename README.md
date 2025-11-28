# Texas Hold'em Poker Hands Kata - Starter

This is a starter repository for the Poker Hands coding kata. The goal is to implement a Texas Hold'em poker hand evaluator.

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
### Problem description:

You work for a cable network; specifically, you are the resident hacker for a Texas Hold’Em Championship show.
The show’s producer has come to you for a favor. It seems the play-by-play announcers just can’t think very fast. All beauty, no brains. The announcers could certainly flap their jaws well enough, if they just knew what hands the players were holding and which hand won the round. Since this is live TV, they need those answers quick. Time to step up to the plate. Bob, the producer, explains what you need to do.

**BOB:** Each player’s cards for the round will be on a separate line of the input. Each card is a pair of characters, the first character represents the face, the second is the suit. Cards are separated by exactly one space. 

Here’s a sample hand.

    Kc 9s Ks Kd 9d 3c 6d
    9c Ah Ks Kd 9d 3c 6d
    Ac Qc Ks Kd 9d 3c
    9h 5s
    4d 2d Ks Kd 9d 3c 6d
    7s Ts Ks Kd 9d

**YOU:** Okay, I was going ask what character to use for 10, but I guess ‘T’ is it. And ‘c’, ’d’, ‘h’ and ’s’ for the suits, makes sense. Why aren’t seven cards listed for every player?

**BOB:** Well, if a player folds, only his hole cards and the community cards he’s seen so far are shown.

**YOU:** Right. And why did the fifth player play with a 4 and 2? They’re suited, but geez, talk about risk…

**BOB:** Stay on topic. Now, the end result of your code should generate output that looks like this:

    Kc 9s Ks Kd 9d 3c 6d Full House (winner)
    9c Ah Ks Kd 9d 3c 6d Two Pair
    Ac Qc Ks Kd 9d 3c
    9h 5s
    4d 2d Ks Kd 9d 3c 6d Flush
    7s Ts Ks Kd 9d

**YOU:** Okay, so I repeat the cards, list the rank or nothing if the player folded, and the word “winner” in parenthesis next to the winning hand. Do you want the cards rearranged at all?

**BOB:** Hmmm… we can get by without it, but if you have the time, do it. Don’t bother for folded hands, but for ranked hands, move the cards used to the front of the line, sorted by face. Kickers follow that, and the two unused cards go at the end, just before the rank is listed.

**YOU:** Sounds good. One other thing, I need to brush up on the hand ranks. You have any good references for Texas Hold’Em?

**BOB:** Yeah, do an internet search on Poker Hand Rankings. And if you need it, the Rules of Texas Hold’Em. While ranking, don’t forget the kicker, the next highest card in their hand if player’s are tied. And of course, if – even after the kicker – player’s are still tied, put “(winner)” on each appropriate line of output.

**YOU:** Ok. I still don’t understand one thing…

**BOB:** What’s that?

**YOU:** Why he stayed in with only the 4 and 2 of diamonds? That’s just…

**BOB:** Hey! Show’s on in ten minutes! Get to work!

### Hand rankings (from weakest to strongest)
A quick cheat-sheet, because yes, you should know the order:

![alt text](./image.png)

 - High card (no pair, highest card wins)
 - One pair
 - Two pairs
 - Three-of-a-kind
 - Straight (five cards in sequence, any suit)
 - Flush (five cards same suit, non-sequence)
 - Full house (three-of-a-kind + pair)
 - Four-of-a-kind
 - Straight flush (sequence + same suit)
 - Royal flush (A-K-Q-J-10 of same suit)

Each player gets two private cards (called hole cards) dealt face-down to them. 
Then five community cards are dealt face-up on the table (in stages) that all players can use. 
Using any combination of your hole cards and/or the community cards, make the best possible five-card poker hand. 

