go
use master
go
use QLCC
go
alter proc SpTHAMSO
(
	@MATS	varchar(20)=null,
	@TENTS	nvarchar(100)=null,
	@APDUNG	bit=1,
	@THOIGIANBATDAU	smalldatetime=null,
	@THOIGIANKETTHUC smalldatetime=null,
	@flag int =0	
)
as
begin 
	if(@flag=0)
		begin
			select MATS,TENTS,convert(char, THOIGIANBATDAU,101)asTHOIGIANBATDAU,convert(char, THOIGIANKETTHUC,101)as THOIGIANKETTHUC,(
			case APDUNG 
				when 1 then 'USE'
				when 0   then 'NOT USE'
			end)as APDUNG
			from THAMSO
		end
	if(@flag=1)
		begin
			if(not exists(select * from THAMSO where MATS=@MATS))
			begin
				INSERT INTO THAMSO
					(
						MATS,
						TENTS,
						APDUNG,
						THOIGIANBATDAU,
						THOIGIANKETTHUC
					)
					VALUES 
					(
						@MATS,
						@TENTS,
						@APDUNG,
						@THOIGIANBATDAU,
						@THOIGIANKETTHUC
					)
				 return 1
			end 
		end
	if(@flag=2)
		begin
			if(exists(select * from THAMSO where MATS=@MATS))
			begin
				UPDATE THAMSO
				SET 
					TENTS = @TENTS,
					APDUNG = @APDUNG,
					THOIGIANBATDAU = @THOIGIANBATDAU,
					THOIGIANKETTHUC = @THOIGIANKETTHUC
				WHERE 
					MATS = @MATS
				return 1
			end
		end
	if(@flag=3)
	begin
		if(exists(select * from THAMSO where MATS=@MATS) )
		begin
			DELETE FROM THAMSO
			WHERE	MATS = @MATS
			return 1
		end
	end
	if(@flag=4)
	begin
		select MATS,TENTS,(
			case APDUNG 
				when 1 then 'USE'
				when 0   then 'NOT USE'
			end)as APDUNG,THOIGIANBATDAU,THOIGIANKETTHUC
		FROM THAMSO
		WHERE
			MATS = @MATS
	end
	if(@flag=5)
	begin
			set @MATS =convert( nvarchar(20), getdate(), 102)
			 set @MATS = replace(@MATS,'.','' );
			 set @MATS = substring ( @MATS , 3, len (@MATS) )  
   			 if (exists (select 'true'  from THAMSO where MATS = 'TS'+@MATS ) )
  			 begin 
  				 declare @i_xxx int 
  				 set @i_xxx = 1 
  				 set @MATS =rtrim(convert( nvarchar(20), @MATS  ) ) + ltrim( convert( nvarchar(20), @i_xxx ))
  				 declare @tmp char(20)
  				 set @tmp = @MATS
  				 while (exists (select 'true'  from THAMSO where MATS = 'TS'+@MATS  ) )
  				 begin 
  					 set @MATS = @tmp
  					 set @i_xxx = @i_xxx + 1
  					 print @i_xxx 
  				 set @MATS =rtrim(convert( nvarchar(20), @MATS  ) ) + ltrim( convert( nvarchar(20), @i_xxx ))
  				 end
  			 end 
  			return @MATS
	end
end
go
