import { Component, Input, OnInit } from '@angular/core';

import { IRoutine } from '../services/routine.model';

@Component({
    selector: 'routine-thumbnail',
    templateUrl: 'routine-thumbnail.component.html',
    styleUrls: ['routine-thumbnail.component.css']
})
export class RoutineThumbnailComponent implements OnInit {
    @Input() routine: IRoutine;

    constructor() { }

    ngOnInit() { }
}