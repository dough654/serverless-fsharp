module Router

open Giraffe


let webApp: HttpHandler =
    choose [
        subRoute "/users" Users.Controller.routes
    ]

//let indexHandler  =
//    fun (next : HttpFunc) (ctx : HttpContext) ->
//
//        text "Serverless Giraffe Web API" next ctx
//
//let webApp:HttpHandler =
//    choose [
//        GET >=>
//            choose [
//                route "/" >=> indexHandler
//            ]
//        setStatusCode 404 >=> text "Not Found" ]