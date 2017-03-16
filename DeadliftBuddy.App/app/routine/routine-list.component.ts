import { Component, OnInit } from '@angular/core';

import { RoutineService } from '../services/routine.service';
import { IRoutine } from '../services/routine.model';

@Component({
    moduleId: module.id,
    selector: 'routine-list',
    templateUrl: 'routine-list.component.html',
    styleUrls: ['routine-list.component.css']
})
export class RoutineListComponent implements OnInit {
    routines: IRoutine[];

    constructor(private routineService: RoutineService) { }

    ngOnInit() {
        this.routineService.getRoutines().subscribe((routines) => {
            if (routines) {
                this.routines = routines;
            } else {
                this.routines = undefined;
            }
        });
    }
}