## W7_LinqJoin

This project aiming to manage authors and books using a relational structure. It involves two tables: **Authors** and **Books**.

### Project Overview

The system consists of the following components:

- **Authors Table**: Contains author details with fields for a unique `AuthorId` and `Name`.
- **Books Table**: Stores book information with a unique `BookId`, `Title`, and `AuthorId`, where `AuthorId` links each book to an author.

### Implementation

1. **Classes**:
    - `Author`: Represents the structure of the **Authors** table.
    - `Book`: Represents the structure of the **Books** table.

2. **Data Addition**:
    - Sample data is added to populate both tables with at least 3 authors and 4 books.

3. **LINQ Query**:
    - A LINQ query is used to join the `Authors` and `Books` tables, retrieving each book title along with the name of its author.

4. **Output**:
    - The result of the LINQ query is printed to display each book title alongside the corresponding author's name in a readable format.

### Notes

- The project demonstrates the use of LINQ's join operation for relational data handling.
- The output format highlights the association between books and authors in the system.