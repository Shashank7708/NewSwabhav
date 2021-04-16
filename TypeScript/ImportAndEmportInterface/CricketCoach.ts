import {Coach} from "./Coach"

export class  cricketCoach implements Coach{
    getWorkout():string{
        return "cricket Coach Training";
    }
}