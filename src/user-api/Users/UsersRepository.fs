namespace Users

open Database
open Microsoft.Data.Sqlite
open System.Threading.Tasks
open FSharp.Control.Tasks.ContextInsensitive
open Users.Models

module Database =
  let getAll connectionString : Task<Result<User seq, exn>> =
    task {
      use connection = new SqliteConnection(connectionString)
      return! query connection "SELECT id, email FROM Users" None
    }

  let getById connectionString id : Task<Result<User option, exn>> =
    task {
      use connection = new SqliteConnection(connectionString)
      return! querySingle connection "SELECT id, email FROM Users WHERE id=@id" (Some <| dict ["id" => id])
    }

  let update connectionString v : Task<Result<int,exn>> =
    task {
      use connection = new SqliteConnection(connectionString)
      return! execute connection "UPDATE Users SET id = @id, email = @email WHERE id=@id" v
    }

  let insert connectionString v : Task<Result<int,exn>> =
    task {
      use connection = new SqliteConnection(connectionString)
      return! execute connection "INSERT INTO Users(id, email) VALUES (@id, @email)" v
    }

  let delete connectionString id : Task<Result<int,exn>> =
    task {
      use connection = new SqliteConnection(connectionString)
      return! execute connection "DELETE FROM Users WHERE id=@id" (dict ["id" => id])
    }

