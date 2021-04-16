import {Coach} from "./Coach"

export class  golfCoach implements Coach{
    getWorkout():string{
        return "Golf Coach Training";
    }
}