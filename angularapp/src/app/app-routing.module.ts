import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListeventsComponent } from './Admin/listevents/listevents.component';
import { AddeventComponent } from './Admin/addevent/addevent.component';


const routes: Routes = [
  {path:'Admin/event',component:ListeventsComponent},
  {path:'Admin/event',component:AddeventComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
