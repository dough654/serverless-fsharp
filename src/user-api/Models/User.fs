namespace Models.User

type UserName = {
    firstName: string
    lastName: string
}

type UserRole =
    | Admin of string
    | User of string
    
module DTO =
    
    type CreateUser = {
        name: UserName
        email: string
        role: string
    }

module Domain = 

    type User = {
        id: string
        name: UserName
        email: string
        role: UserRole
    }
    