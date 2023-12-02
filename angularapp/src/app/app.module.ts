import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListeventsComponent } from './Admin/listevents/listevents.component';
import { HttpClientModule } from '@angular/common/http';
import { EditeventComponent } from './Admin/editevent/editevent.component';
import { AddeventComponent } from './Admin/addevent/addevent.component';
import {FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DeleteeventComponent } from './Admin/deleteevent/deleteevent.component';
import { ListbookingsComponent } from './Admin/listbookings/listbookings.component';
import { ListpaymentsComponent } from './Admin/listpayments/listpayments.component';
import { EventbytypeComponent } from './Admin/eventbytype/eventbytype.component';

@NgModule({
  declarations: [
    AppComponent,
    ListeventsComponent,
    EditeventComponent,
    AddeventComponent,
    DeleteeventComponent,
    ListbookingsComponent,
    ListpaymentsComponent,
    EventbytypeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
