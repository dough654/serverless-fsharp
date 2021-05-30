namespace Users

open Microsoft.AspNetCore.Http
open Giraffe
open Users.Models
//open Config

module Controller =

    let mutable Users : User list =
        [ { id = 123; email = "test1@email.com" }
          { id = 124; email = "test2@email.com" }
          { id = 125; email = "test3@email.com" }
          { id = 126; email = "test4@email.com" } ]

    let getUsers ctx = json Users ctx

    let routes: HttpHandler =
        choose [ GET >=> choose [ route "" >=> getUsers ] ]
