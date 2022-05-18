# EveryoneManagesMerchandise
누구나 쉽게 비즈니스를 관리할 수 있는 시스템을 구축중입니다. 

회계, 인사, 주문, 물류, 판매 등의 업무를 볼 수 있도록 구축중입니다.

개발과 관련한 구체적인 도면 및 설명은 Blog를 통해 확인하실 수 있습니다.

https://blog.naver.com/powerqkrcjfd

## 프로세스 명세서
1. 구매대행 관리 시스템
2. 물류대행 관리 시스템
3. 농수산물 수의거래 시스템
4. 주문자 상물처리 프로세스와 상물관리 시스템

## Architecture 및 .Net Standard Project
![image](https://user-images.githubusercontent.com/25167316/169029960-f31c30f9-9381-4f6c-9f8a-b0a5f756755a.png)
1. DataAcceLayer - BusinessData
2. BusinessLogicLayer - BusinessLogic
3. Presentation Layer - BusinessView

## 공통모듈
BusinessData 프로젝트 안에 포함하는 모듈들은 주로 BusinessLogic.EntityManager 라는 모듈이 포함합니다.

BusinessLogic 프로젝트 안에 포함하는 모듈들은 주로 Asp.net Core Web API Server에서 DI 되어 이용됩니다.

BusinessView 프로젝트 안에 포함하는 모듈들은 주로 Asp.net Core Blazor Server에서 DI 되어 이용됩니다.

## BusinessData
### BusinessData 프로젝트의 특징
![image](https://user-images.githubusercontent.com/25167316/169031834-b4298c6f-c797-4623-b907-cce484e0c74f.png)
1. Model을 Entity, Center, Commodity, Status 로 구분합니다.
2. 모든 Model은 Entity 개체를 상속합니다.
3. 사업장과 관련한 Model은 모두 Center 개체를 상속합니다.
4. 사업장의 상품과 관련한 개체는 모두 Commodity 개체를 상속합니다.
5. 사업장 상품의 상태와 관련한 개체는 모두 Status 개체를 상속합니다.
6. 상품과 관련한 모든 업무를 시작, 중간, 끝으로 구분하며 Status 개체로 S(시작), M(중간), E(끝) 개체를 상속합니다.

### [주요기술]
1. EntityFrameWork Core
2. Fluent API를 활용한 DbContext 생성
3. Repository Pattern 이용
4. EntityTypeConfigration 을 통한 형식 당 테이블 생성
5. Relation 특성과 리플렉션을 통한 DbContext 유추생성

Dbcontext 유추코드

  _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));

유추코드 끝

## BusinessLogic
### BusinessLogic 프로젝트의 특징
![image](https://user-images.githubusercontent.com/25167316/169030079-b320aea4-b93c-4869-beab-887d3a89791e.png)
1. Generic 폴더의 EntityManager 라는 모듈이 통합역할을 담당합니다.
2. 상기 Manager 모듈이 Id, Repository, BlobStorage, File 관리역할을 담당합니다.
3. Model 구분과 마찬가지로 Entity-Center-Commodity-Status 로 Manager 모듈을 구분합니다.

생성패턴을 통해 EntityManager 모듈을 만드는 게 어땠을까? 라는 고민이 있습니다. 또한 통합적으로 정형 및 비정형 데이터를 관리한다는 장점이 있지만 객체지향 설계원칙 중 단일책임원칙을 위배하고 있어 어떻게 재설계할지가 고민입니다.

### [주요기술]
1. 특성을 통한 Id 설정
2. Azure Blob Storage (비정형 데이터)
3. Repository (정형 데이터)

### [개발예정]
Quartz.net을 통한 배치모듈을 추가할 예정입니다.
https://www.quartz-scheduler.net/documentation/quartz-3.x/quick-start.html#trying-out-the-application-and-adding-jobs

## BusinessView
### BusinessView 프로젝트의 특징
유스케이스 다이어그램에서 Actor와 소프트웨어 디자인 패턴 중 생성패턴에 영감을 받아 작성된 ActorContext 모듈을 포함합니다. Web API Server와 데이터 통신할 때 이용되는 DTO 개체를 포함합니다. 또한 MVVM 개발패턴에 이용될 ViewModel 개체를 포함합니다.

### 핵심개체
1. ActorContext
2. DTO
3. ViewModel

### ActorContext의 역할
![image](https://user-images.githubusercontent.com/25167316/169028849-bdbf24e6-ef95-4b5b-a191-9385d393a223.png)
1. DTO 적합성 검사 (Fluent Validation)
2. DTO InMemory 저장소 관리 (NMemory)
3. DTO를 통한 Web API Server와 데이터 통신 

### ViewModel의 역할
![image](https://user-images.githubusercontent.com/25167316/169030714-e659ed8d-1780-4ebc-add8-d0fb1e6a55c4.png)
1. INotifyProperyChanged 인터페이스를 통해 상태변화가 반영될 수 있도록 합니다.
2. Entity-Center-Commodity-Status에 따 View 단 프론트 코드를 정형화합니다.
3. EntityPageViewModel 과 EntityPost,Put,Delete,GetsViewModel 로 구분됩니다.

### DTO 의 역할 (DataTransfer Object)
1. 관계성에 속하는 데이터를 포함해서 Query 할 때 1 그리고 N에 해당하는 개체를 Json String 형식으로 받아옵니다.
2. 이후 View단에서 1 또는 N 개체에 해당하는 데이터를 이용할 때 역직렬화 하여 View 단에서 조회할 수 있도록 합니다.
3. 기본적인 DataTranferObject 역할을 수행합니다.

### [주요기술]
1. 생성패턴을 통한 ActorContext 생성
2. Model To DTO, DTO To Model Mapper
3. MVVM 개발패턴에 따른 ViewModel
4. NMemory Library
5. FluentValidation.Net Library
6. Get, Detail, One, Many 특성을 통한 DTO 분류
7. PropertyClassification 모듈을 통한 DTO Property 분류

https://nmemory.net/

https://docs.fluentvalidation.net/en/latest/upgrading-to-9.html?highlight=Ivalidationcontext



  
