import { Routes } from '@angular/router';

import { RoutineListComponent } from './routine/routine-list.component';
import { RoutineDetailsComponent } from './routine/routine-details.component';
import { RoutineResolver } from './services/routine-resolver.service';

import { Error404Component } from './errors/404.component';

export const appRoutes: Routes = [
    { path: '', component: RoutineListComponent },
    { path: 'routines/:id', component: RoutineDetailsComponent, resolve: { routine: RoutineResolver } },
    { path: '404', component: Error404Component }
]