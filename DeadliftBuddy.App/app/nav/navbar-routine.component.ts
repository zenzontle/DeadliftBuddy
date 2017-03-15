﻿import { Component, OnInit } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'navbar-routine',
    templateUrl: 'navbar-routine.component.html',
    styleUrls: ['navbar-routine.component.css']
})
export class NavBarRoutineComponent implements OnInit {
    routine: string = 'Not specified';

    constructor() { }

    ngOnInit() { }
}