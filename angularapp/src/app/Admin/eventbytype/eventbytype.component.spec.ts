import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EventbytypeComponent } from './eventbytype.component';

describe('EventbytypeComponent', () => {
  let component: EventbytypeComponent;
  let fixture: ComponentFixture<EventbytypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EventbytypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EventbytypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
