import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListeventsComponent } from './Admin/listevents/listevents.component';
import { AddeventComponent } from './Admin/addevent/addevent.component';
import { EditeventComponent } from './Admin/editevent/editevent.component';
import { ListpaymentsComponent } from './Admin/listpayments/listpayments.component';


const routes: Routes = [
  {path:'Admin/event',component:ListeventsComponent},
  {path:'Admin/event',component:AddeventComponent},
  {path:'updateevent/:id',component:EditeventComponent},
  {path:'listpayments',component:ListpaymentsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
