import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServerFeedsComponent } from './server-feeds.component';

describe('ServerFeedComponent', () => {
  let component: ServerFeedsComponent;
  let fixture: ComponentFixture<ServerFeedsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServerFeedsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServerFeedsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
