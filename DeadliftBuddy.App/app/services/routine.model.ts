export interface IRoutine {
    id: number;
    name: string;
    exercises: IExercise[];
}

export interface IExercise {
    id: number;
    description: string;
    currentWeight: number;
}
