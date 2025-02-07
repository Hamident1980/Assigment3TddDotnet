## Assignment 3

### Objective:

Implement a class that compresses a given string using the following rules:

- If a character appears consecutively more than once, replace it with the character followed by the count.
- For example: "aabcccccaaa" would be compressed to "a2b1c5a3".
- If the compressed string is not shorter than the original string, return the original string.

### Requirements:

- Create a StringCompressor class: This class will have a single public method: String compress(String str).

#### Implement the following functionality using TDD:
- Handle empty strings: An empty string should remain empty.
- Handle strings with no consecutive characters: The string should remain unchanged.
- Handle strings with consecutive characters: Compress the string according to the rules.
- Handle strings where compression doesn't reduce length: Return the original string.

#### Write Unit Tests:

Write comprehensive unit tests for each of the above requirements using JUnit or a similar testing framework.
Cover various scenarios, including:
- Empty strings
- Strings with no consecutive characters
- Strings with various patterns of consecutive characters
- Strings where compression increases the length

### Submission:

Submit via github name the repo as *YourName_Assignment3*

- The tests should be running using github actions

### Grading:

- Correctness: 50% (Accurate compression of strings according to the rules and proper handling of all scenarios.)
- Test Coverage: 30% (Thoroughness and quality of unit tests, including edge case coverage.)
- Code Quality: 20% (Code readability, maintainability, and adherence to good coding practices.)

### Bonus:

- Handle cases with more than 9 consecutive characters.
- Implement a decompression method to decompress the compressed string back to its original form.// Trigger GitHub Actions
