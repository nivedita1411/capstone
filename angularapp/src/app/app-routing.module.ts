import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListeventsComponent } from './Admin/listevents/listevents.component';
import { AddeventComponent } from './Admin/addevent/addevent.component';
import { EditeventComponent } from './Admin/editevent/editevent.component';
import { ListpaymentsComponent } from './Admin/listpayments/listpayments.component';
import { ListbookingsComponent } from './Admin/listbookings/listbookings.component';
import { DeleteeventComponent } from './Admin/deleteevent/deleteevent.component';
import { EventbytypeComponent } from './Admin/eventbytype/eventbytype.component';


const routes: Routes = [
  {path:'Admin/event',component:ListeventsComponent},
  {path:'Admin/event',component:AddeventComponent},
  {path:'updateevent/:id',component:EditeventComponent},
  {path:'listpayments',component:ListpaymentsComponent},
  {path:'listbookings',component:ListbookingsComponent},
  {path:'deleteevent/:id',component:DeleteeventComponent},
  {path:'searchbytype', component:EventbytypeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
