# EFSQLite
EFSQLite tests

# After 1st and then 2nd run:
sqlite3 /Users/curly/.local/share/EFSQLite/db.sqlite
SQLite version 3.36.0 2021-06-18 18:58:49
Enter ".help" for usage hints.
sqlite> .schema
CREATE TABLE IF NOT EXISTS "users" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_users" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL
);
CREATE TABLE sqlite_sequence(name,seq);
sqlite> select * from users;
1|c1
2|123456789012345678901234567890
sqlite> .schema
CREATE TABLE IF NOT EXISTS "users" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_users" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NOT NULL
);
CREATE TABLE sqlite_sequence(name,seq);
sqlite> select * from users;
1|c1
2|123456789012345678901234567890
3|c1
4|123456789012345678901234567890
sqlite> 

