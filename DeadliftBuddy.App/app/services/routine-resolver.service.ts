import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve } from '@angular/router';
import { RoutineService } from './routine.service';

@Injectable()
export class RoutineResolver implements Resolve<any> {
    constructor(private routineService: RoutineService) {

    }

    resolve(route: ActivatedRouteSnapshot) {
        return this.routineService.getRoutine(route.params['id']);
    }
}