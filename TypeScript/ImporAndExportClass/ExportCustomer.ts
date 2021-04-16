export class Customer{
   private _firstname:string;
  private  _lastname:string;

    constructor(firstname:string,lastname:string){
        this._firstname=firstname;
        this._lastname=lastname;
    }

    public get firstname():string{
        return this._firstname
    }
    public get lastname():string{
        return this._lastname;
    }

}