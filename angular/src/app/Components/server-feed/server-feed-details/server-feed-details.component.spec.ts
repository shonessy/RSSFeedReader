import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServerFeedDetailsComponent } from './server-feed-details.component';

describe('ServerFeedDetailsComponent', () => {
  let component: ServerFeedDetailsComponent;
  let fixture: ComponentFixture<ServerFeedDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServerFeedDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServerFeedDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
