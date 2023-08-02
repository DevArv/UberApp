//Definition of the "User" class, which inherits from the class "Car".

class User extends Account {
    constructor(id, name, document){
    super(name, document)
    this.id = id;
    }

    printDataUser() {
        console.log(this.id)
        console.log(this.name)
        console.log(this.document)
    }
}