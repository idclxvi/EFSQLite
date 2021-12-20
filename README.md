# EFSQLite
EFSQLite tests

# After 1st run:
```
sqlite3 ~/.local/share/EFSQLite/fluent.sqlite
SQLite version 3.36.0 2021-06-18 18:58:49
Enter ".help" for usage hints.
sqlite> .schema
CREATE TABLE IF NOT EXISTS "users" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_users" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL,
    CONSTRAINT "AK_users_Name" UNIQUE ("Name")
);
CREATE TABLE sqlite_sequence(name,seq);
sqlite> select * from users;
1|c1
2|123456789012345678901234567890
sqlite> 
```

2nd run fails:
```
Using: /Users/curly/.local/share/EFSQLite/fluent.sqlite
Unhandled exception. Microsoft.EntityFrameworkCore.DbUpdateException: An error occurred while saving the entity changes. See the inner exception for details.
 ---> Microsoft.Data.Sqlite.SqliteException (0x80004005): SQLite Error 19: 'UNIQUE constraint failed: users.Name'.
```
