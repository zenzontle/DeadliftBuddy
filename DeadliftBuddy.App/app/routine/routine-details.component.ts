import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { IRoutine } from '../services/routine.model';

@Component({
    moduleId: module.id,
    selector: 'routine-details',
    templateUrl: 'routine-details.component.html',
    styleUrls: ['routine-details.component.css']
})
export class RoutineDetailsComponent implements OnInit {
    routine: IRoutine;

    constructor(private route: ActivatedRoute) { }

    ngOnInit() {
        this.route.data.forEach((data) => {
            this.routine = data['routine'];
        });
    }
}