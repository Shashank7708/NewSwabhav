class Person{
  private _id1:number;
 private _name:any

public setid(id1:number) {
    this._id1=id1;  
}
public getid() {
    return this._id1;
}

public setname(n:any) {
    this._name=n;
}
public  getname(){
    return this._name;
}
}
let person=new Person();
person.setid(10);
person.setname('Rahul');
console.log("id:"+person.getid());
console.log(" name: "+person.getname());
