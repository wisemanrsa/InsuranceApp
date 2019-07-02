import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PremiumManagerComponent } from './premium-manager.component';

describe('PremiumManagerComponent', () => {
  let component: PremiumManagerComponent;
  let fixture: ComponentFixture<PremiumManagerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PremiumManagerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PremiumManagerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
