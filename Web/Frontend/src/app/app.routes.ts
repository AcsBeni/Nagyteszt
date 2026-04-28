import { Routes } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { PlantsComponent } from './components/plants/plants.component';
import { WateringComponent } from './components/watering/watering.component';

export const routes: Routes = [

    {path:"", component:DashboardComponent},
    {path:"plants", component:PlantsComponent},
    {path:"watering", component:WateringComponent},
];
