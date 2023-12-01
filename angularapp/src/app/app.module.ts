import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListeventsComponent } from './Admin/listevents/listevents.component';
import { HttpClientModule } from '@angular/common/http';
import { EditeventComponent } from './Admin/editevent/editevent.component';
import { AddeventComponent } from './Admin/addevent/addevent.component';
import {ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ListeventsComponent,
    EditeventComponent,
    AddeventComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
