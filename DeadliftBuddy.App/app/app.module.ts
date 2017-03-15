import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';

import { NavBarDashboardComponent } from './nav/navbar-dashboard.component';
import { RoutineListComponent } from './routine/routine-list.component';
import { RoutineThumbnailComponent } from './routine/routine-thumbnail.component';
import { NavBarRoutineComponent } from './nav/navbar-routine.component';
import { RoutineDetailsComponent } from './routine/routine-details.component';

import { RoutineResolver } from './services/routine-resolver.service';
import { RoutineService } from './services/routine.service';

import { appRoutes } from './routes';

@NgModule({
    declarations: [
        AppComponent,
        NavBarDashboardComponent,
        RoutineListComponent,
        RoutineThumbnailComponent,
        NavBarRoutineComponent,
        RoutineDetailsComponent
    ],
    providers: [
        RoutineService,
        RoutineResolver
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        RouterModule.forRoot(appRoutes)
    ],
    bootstrap: [
        AppComponent
    ]
})

export class AppModule { }