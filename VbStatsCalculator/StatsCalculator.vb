Imports System
Imports System.Collections.Generic

Namespace VbStatsCalculator
    Public Class StatsCalculator
        Public Sub New(ByVal ivalues As List(Of Int32))
            Values() = New Integer(ivalues.Count) {}
            For i = 0 To ivalues.Count Step 1
                Values(i) = ivalues(i)
            Next
            Array.Sort(Values)
            IntializeBookkeeping()

        End Sub

        Private Sub IntializeBookkeeping()
            MeanCalculated = False
            ModeCalculated = False
            MedianCalculated = False

            m_mean = -1
            m_mode = -1
            m_modeFrequency = -1
            m_median = -1
        End Sub
        Private m_Values As Integer()
        Public Property Values As Integer()
            Get
                Return m_Values
            End Get
            Set(ByVal value As Integer())
                m_Values = value
            End Set
        End Property
        Private m_MeanCalculated As Boolean
        Private Property MeanCalculated As Boolean
            Get
                Return m_MeanCalculated
            End Get
            Set(ByVal value As Boolean)
                m_MeanCalculated = value
            End Set
        End Property
        Private m_ModeCalculated As Boolean
        Private Property ModeCalculated As Boolean
            Get
                Return m_ModeCalculated
            End Get
            Set(ByVal value As Boolean)
                m_ModeCalculated = value
            End Set
        End Property
        Private m_medianCalculated As Boolean
        Private Property MedianCalculated As Boolean
            Get
                Return m_medianCalculated
            End Get
            Set(ByVal value As Boolean)
                m_medianCalculated = value
            End Set
        End Property
        Private m_mean As Double
        Public ReadOnly Property Mean As Double
            Get
                Return CalculateMean()
            End Get
        End Property
        Private m_mode, m_modeFrequency As Integer
        Public ReadOnly Property Mode As Integer
            Get
                CalculateMode(m_mode, m_modeFrequency)
                Return m_mode
            End Get
        End Property
        Public ReadOnly Property ModeFrequency As Integer
            Get
                CalculateMode(m_mode, m_modeFrequency)
                Return m_modeFrequency
            End Get
        End Property
        Private m_median As Integer
        Public ReadOnly Property Median As Integer
            Get
                CalculateMedian(m_median)
                Return m_median
            End Get
        End Property
        Private Function CalculateMean() As Double
            If Not MeanCalculated Then
                Dim sum As Integer = 0
                For Each i As Integer In Values
                    sum += i
                Next
                m_mean = CDbl(sum) / Values.Length
                MeanCalculated = True
            End If
            Return m_mean
        End Function
        Private Sub CalculateMode(ByRef o_mode As Integer, ByRef o_frequency As Integer)
            Dim val As Integer = 0
            If Not ModeCalculated Then
                Dim freq As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
                For Each i As Integer In Values
                    If Not freq.ContainsKey(i) Then
                        freq.Add(i, 0)
                    End If
                    freq(i) += 1
                Next
                Dim flag As Boolean = False
                For Each i As Integer In freq.Keys
                    If flag Then
                        If freq(val) < freq(i) Then
                            val = i
                        End If
                    Else
                        flag = True
                        val = i
                    End If
                Next
                ModeCalculated = True
                m_mode = val
                m_modeFrequency = freq(val)
            End If
            o_mode = m_mode
            o_frequency = m_modeFrequency
        End Sub
        Private Sub CalculateMedian(ByRef o_median As Integer)
            If Not MedianCalculated Then
                Dim half As Integer = 2
                Dim startIndex As Integer = 0
                Dim endIndex As Integer = Values.Length - 1
                Dim middle As Integer = (endIndex - startIndex + 1) / half
                MedianCalculated = True
                m_median = Values(middle)
            End If
            o_median = m_median
        End Sub
    End Class
End Namespace
