
import {Pipe,PipeTransform} from '@angular/core';
@Pipe({
    name:'snakeCase'
})

export class SnakeCasePipe implements PipeTransform{
    transform(value:string,limit:number):string{
        var word:string[]=value.split(' ');
        var newValue:string="";
        console.log(word.length);
        
    if(word.length<=limit){
        newValue=word.join("_");
    }else{
        word=word.slice(0,5);
    }
    return newValue;



}
}