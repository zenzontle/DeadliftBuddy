import { Component } from '@angular/core';

import { RoutineService } from './services/routine.service';

@Component({
    moduleId: module.id,
    selector: 'app-root',
    templateUrl: 'app.component.html'
})
export class AppComponent {
    title = 'app works!';
    routine = '';

    constructor(private routineService: RoutineService) { }

    getIt() {
        this.routineService.getRoutines().subscribe((response) => {
            if (response) {
                this.routine = response.toString();
            } else {
                this.routine = 'Not found';
            }
        });
    }
}