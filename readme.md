# Top K Frequent Elements

This repository contains a solution for finding the Top K Frequent Elements in an integer array, implemented in C#. It's a common interview question for software engineering roles at various tech companies.

## Problem Statement

Given a non-empty array of integers, return the k most frequent elements.

## Solution

The solution uses a `Dictionary` to count the frequency of each number and a `List` to store the frequency and number as a tuple. After populating the `List`, it is sorted in descending order of frequency. Then the k most frequent numbers are selected from the sorted list.

When iterating through the dictionary, each entry is added to the `List`. The list is then sorted by frequency in descending order. Finally, the k most frequent elements are selected from the sorted list.

## Running the Code

The solution is implemented as a Console Application in C#. To run the code, you need to have .NET Core installed on your machine. Follow these steps:

1. Clone the repository to your local machine.
2. Open a terminal and navigate to the directory of the cloned repository.
3. Run the command `dotnet run`.

The program will execute, and you will see the output of the `TopKFrequent` method call in the console.

## Contributing

This is a simple educational project. Contributions are not expected, but if you see something that could be improved, feel free to open a pull request.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.
