import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BuildlogComponent } from './buildlog.component';

describe('BuildlogComponent', () => {
  let component: BuildlogComponent;
  let fixture: ComponentFixture<BuildlogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BuildlogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BuildlogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
