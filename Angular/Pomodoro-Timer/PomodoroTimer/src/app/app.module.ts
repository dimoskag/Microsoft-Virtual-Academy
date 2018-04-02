import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


import { AppComponent } from './app.component';
import { PomodoroTimerComponent } from './pomodoro-timer/pomodoro-timer.component';


@NgModule({
  declarations: [
    AppComponent,
    PomodoroTimerComponent
  ],
  imports: [
    BrowserModule,
    NgbModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent, PomodoroTimerComponent]
})
export class AppModule { }
