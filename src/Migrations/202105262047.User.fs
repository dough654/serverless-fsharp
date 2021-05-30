namespace Migrations
open SimpleMigrations

[<Migration(202105262047L, "Create Users")>]
type CreateUsers() =
  inherit Migration()

  override __.Up() =
    base.Execute(@"CREATE TABLE Users(
      id INT NOT NULL,
      email TEXT NOT NULL
    )")

  override __.Down() =
    base.Execute(@"DROP TABLE Users")
