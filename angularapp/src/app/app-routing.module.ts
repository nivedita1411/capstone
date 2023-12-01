import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListeventsComponent } from './Admin/listevents/listevents.component';
import { AddeventComponent } from './Admin/addevent/addevent.component';
import { EditeventComponent } from './Admin/editevent/editevent.component';


const routes: Routes = [
  {path:'Admin/event',component:ListeventsComponent},
  {path:'Admin/event',component:AddeventComponent},
  {path:'Admin/admin/updateevent/:id',component:EditeventComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
