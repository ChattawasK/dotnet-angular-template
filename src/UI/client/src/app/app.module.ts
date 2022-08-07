import { LeaveTypeService } from '../shared/services/leave-type.service';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';

/* Third Party */
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

const thirdParty = [NgbModule];
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ...thirdParty
  ],
  providers: [LeaveTypeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
